using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using OnlinePharmacy.Server.Data;
using OnlinePharmacy.Server.IRepository;
using OnlinePharmacy.Shared.Domain;

namespace OnlinePharmacy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public StaffsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }


        // GET: api/Staffs
        [HttpGet]
        public async Task<IActionResult> GetStaffs()
        {

    
            var staffs = await _unitOfWork.Staffs.GetAll();

            return Ok(staffs);



            // You might return ObjectResult or another appropriate result type here
            //return Ok(staffs);


            //var staffs = await _unitOfWork.Staffs.GetAll();
            //return Ok(staffs);

            //var staffs = await _unitOfWork.Staffs.GetAll(); // Assuming GetAll returns all staff members

            // Filter staffs with the first name "Tom"
            //var filteredStaffs = staffs.Where(b => b.StaffFname.Equals("Tom")).ToList();

            //return Ok(filteredStaffs);

        }



        // GET: api/Staffs/5
        [HttpGet("{id}")]
        public async Task<IActionResult>GetStaff(int id)
        {
            var staff = await _unitOfWork.Staffs.Get(q => q.StaffID == id);
            if(staff == null)
            {
                return NotFound();
            }
            return Ok(staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.StaffID)
            {
                return BadRequest();
            }

            _unitOfWork.Staffs.Update(staff);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await StaffExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.StaffID }, staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var staff = await  _unitOfWork.Staffs.Get(q => q.StaffID == id);
            if(staff == null)
            {
                return NotFound();
            }

            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);
            
            return NoContent();
           
        }

        private async Task<bool> StaffExists(int id)
        {
            var staff = await _unitOfWork.Staffs.Get(q => q.StaffID == id);
            return staff != null;
        }
    }
}
