// using Application.Activities;
// using Application.Core;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities(){
            return await _context.Activities.ToListAsync();
        }
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
        // [HttpGet]
        // public async Task<IActionResult> GetActivities([FromQuery] ActivityParams param)
        // {
        //     return HandlePagedResult(await Mediator.Send(new List.Query { Params = param }));
        // }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetActivity(Guid id)
        // {
        //     return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        // }

        // [HttpPost]
        // public async Task<IActionResult> CreateActivity(Activity activity)
        // {
        //     return HandleResult(await Mediator.Send(new Create.Command { Activity = activity }));
        // }

        // [Authorize(Policy = "IsActivityHost")]
        // [HttpPut("{id}")]
        // public async Task<IActionResult> Edit(Guid id, Activity activity)
        // {
        //     activity.Id = id;
        //     return HandleResult(await Mediator.Send(new Edit.Command { Activity = activity }));
        // }

        // [Authorize(Policy = "IsActivityHost")]
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(Guid id)
        // {
        //     return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        // }

        // [HttpPost("{id}/attend")]
        // public async Task<IActionResult> Attend(Guid id)
        // {
        //     return HandleResult(await Mediator.Send(new UpdateAttendance.Command { Id = id }));
        // }
    }
}