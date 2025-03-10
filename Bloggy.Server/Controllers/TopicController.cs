using Bloggy.Server.DB;
using Bloggy.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bloggy.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class TopicController : ControllerBase
{
    
    private readonly ILogger<TopicController> _logger;
    private readonly DatabaseContext dbContext;

    public TopicController(ILogger<TopicController> logger, DatabaseContext dbContext)
    {
        _logger = logger;
        this.dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetTopics()
    {
        var topics = dbContext.Topics.ToList();
        return Ok(topics);
    }
}
