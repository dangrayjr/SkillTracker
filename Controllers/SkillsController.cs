using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet("skills")]
        
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Programming Languages</h2>" +
                "<ol>" +
                "<li>Javascript</li>" +
                "<li>C Sharp</li>" +
                "<li>Python</li>" +
                "</ol>";

                return Content(html, "text/html");
        }

        [HttpGet("skills/form")]

        public IActionResult DisplaySkillForm()
        {
            string html = "<form method = 'post' action = 'form'>" +
            "<label for='start'>Date: </label>" +
            "<input type = 'date' id = 'start' name = 'date'/>" +
            "<br>"+
            "<label for ='CSharp'> C Sharp: </label>" +
            "<select name='CSharp' id='CSharp'>"+
            "< option value = 'none' > Select progress </ option > " +
                "<option value = 'Learning Basics' > Learning Basics </option>" +
                "<option value = 'Making Apps' > Making Apps </option>" +
                "<option value = 'Master Coder' >Master Coder</option>" +
            "</select>" +
            "<br>" +
            "<label for ='JavaScript'> Javascript: </label>" +
            "<select name='JavaScript' id='JavaScript'>" +
            "< option value = 'none' > Select progress </ option > " +
                "<option value = 'Learning Basics' > Learning Basics </option>" +
                "<option value = 'Making Apps' > Making Apps </option>" +
                "<option value = 'Master Coder' >Master Coder</option>" +
            "</select>" +
            "<br>" +
            "<label for ='Python'> Python: </label>" +
            "<select name='Python' id='Python'>" +
            "< option value = 'none' > Select progress </ option > " +
                "<option value = 'Learning Basics' > Learning Basics </option>" +
                "<option value = 'Making Apps' > Making Apps </option>" +
                "<option value = 'Master Coder' >Master Coder</option>" +
            "</select>" +
            "<br>" +
            "<input type='submit' value='Submit' />" +
            "</form>";

            return Content(html, "text/html");
        }

        [HttpPost("skills/form")]
        public IActionResult Form(string date, string CSharp, string JavaScript, string Python) 
        {
            string html = "<h1>" + date + "</h1>" +
                "<ol>" +
                "<li>CSharp: " + CSharp + "</li>" +
                "<li>JavaScript: " + JavaScript + "</li>" +
                "<li>Python: " + Python + "</li>" +
                "</ol>";

            return Content(html, "text/html");

        }
    
            
            }
}
