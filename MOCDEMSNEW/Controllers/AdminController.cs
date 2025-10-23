using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MOCDEMSNEW.Models;

namespace MOCDEMSNEW.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        // /admin
        [HttpGet("admin")]
        public IActionResult Index()
        {
            return View();
        }

        #region Setup
        [HttpGet("admin/setup")]
        public IActionResult Setup()
        {
            return View("Setup/Index");
        }

        #region Department
        // /admin/setup/department
        [HttpGet("admin/setup/department")]
        public IActionResult Department()
        {
            return View("Setup/Department/Index");
        }

        // /admin/setup/department/new
        [HttpGet("admin/setup/department/new")]
        public IActionResult NewDepartment()
        {
            return View("Setup/Department/NewDepartment");
        }
        #endregion

        #region SubDepartment
        [HttpGet("admin/setup/SubDepartment")]
        public IActionResult SubDepartment()
        {
            return View("Setup/SubDepartment/Index");
        }
        
        [HttpGet("admin/setup/SubDepartment/new")]
        public IActionResult NewSubDepartment()
        {
            return View("Setup/SubDepartment/NewSubDepartment");
        }
        #endregion

        #region Section
        [HttpGet("admin/setup/section")]
        public IActionResult Section()
        {
            return View("Setup/Section/Index");
        }

        [HttpGet("admin/setup/section/new")]
        public IActionResult NewSection()
        {
            return View("Setup/Section/NewSection");
        }
        #endregion

        #region Position
        [HttpGet("admin/setup/position")]
        public IActionResult Position()
        {
            return View("Setup/Position/Index");
        }

        [HttpGet("admin/setup/position/new")]
        public IActionResult NewPosition()
        {
            return View("Setup/Position/NewPosition");
        }
        #endregion

        #region UserRank
        [HttpGet("admin/setup/UsrRank")]
        public IActionResult UserRank()
        {
            return View("Setup/UserRank/Index");
        }
        #endregion

        #region SecurityType
        [HttpGet("admin/setup/SecType")]
        public IActionResult SecurityType()
        {
            return View("Setup/SecurityType/Index");
        }

        [HttpGet("admin/setup/SecType/new")]
        public IActionResult NewSecurityType()
        {
            return View("Setup/SecurityType/NewSecurityType");
        }
        #endregion

        #region User
        [HttpGet("admin/setup/user")]
        public IActionResult Users()
        {
            return View("Setup/User/Index");
        }

        [HttpGet("admin/setup/user/new")]
        public IActionResult NewUser()
        {
            return View("Setup/User/NewUser");
        }
        #endregion

        #region FileManager
        [HttpGet("admin/setup/FileManager")]
        public IActionResult FileManager()
        {
            return View("Setup/FileManager/Index");
        }

        [HttpGet("admin/setup/FileManager/new")]
        public IActionResult NewFileManager()
        {
            return View("Setup/FileManager/NewFileManager");
        }
        #endregion

        #region MeetingType
        [HttpGet("admin/setup/MeetType")]
        public IActionResult MeetingType()
        {
            return View("Setup/MeetingType/Index");
        }

        [HttpGet("admin/setup/MeetType/new")]
        public IActionResult NewMeetingType()
        {
            return View("Setup/MeetingType/NewMeetingType");
        }
        #endregion

        #region Venue
        [HttpGet("admin/setup/venue")]
        public IActionResult Venue()
        {
            return View("Setup/Venue/Index");
        }

        [HttpGet("admin/setup/venue/new")]
        public IActionResult NewVenue()
        {
            return View("Setup/Venue/NewVenue");
        }
        #endregion

        #endregion

        #region Report
        [HttpGet("admin/report")]
        public IActionResult Report()
        {
            return View("Report/Index");
        }

        #region ReportCategory
        [HttpGet("admin/report/RepCategory")]
        public IActionResult ReportCategory()
        {
            return View("Report/ReportCategory/Index");
        }

        [HttpGet("admin/report/RepCategory/new")]
        public IActionResult NewReportCategory()
        {
            return View("Report/ReportCategory/NewReportCategory");
        }
        #endregion

        #region ArchiveReportCategory
        [HttpGet("admin/report/ArcRepCategory")]
        public IActionResult ArchiveReportCategory()
        {
            return View("Report/ArchiveReportCategory/Index");
        }
        #endregion
        #region Reports
        [HttpGet("admin/report/reports")]
        public IActionResult Reports()
        {
            return View("Report/Reports/Index");
        }
        #endregion

        #region TurnDownReport
        [HttpGet("admin/report/TDownReport")]
        public IActionResult TurnDownReport()
        {
            return View("Report/TurnDownReport/Index");
        }
        #endregion

        #region ReportRemarkCategory
        [HttpGet("admin/report/RepRemarkCategory")]
        public IActionResult ReportRemarkCategory()
        {
            return View("Report/ReportRemarkCategory/Index");
        }

        [HttpGet("admin/report/RepRemarkCategory/new")]
        public IActionResult NewReportRemarkCategory() {
            return View("Report/ReportRemarkCategory/NewReportRemarkCategory");
        }
        #endregion

        #region ReportRemarkType
        [HttpGet("admin/report/RepRemarkType")]
        public IActionResult ReportRemarkType()
        {
            return View("Report/ReportRemarkType/Index");
        }

        [HttpGet("admin/report/RepRemarkType/new")]
        public IActionResult NewReportRemarkType()
        {
            return View("Report/ReportRemarkType/NewReportRemarkType");
        }
        #endregion

        #endregion

        #region RemarkType
        [HttpGet("admin/RemarkType")]
        public IActionResult RemarkType()
        {
            return View("RemarkType/Index");
        }
        [HttpGet("admin/RemarkType/new")]
        public IActionResult NewRemarkType()
        {
            return View("RemarkType/NewRemarkType");
        }
        #endregion

        #region OfficeLetter
        [HttpGet("admin/OfficeLetter")]
        public IActionResult OfficeLetter()
        {
            return View("OfficeLetter/Index");
        }
        #region OfficeLetters
        [HttpGet("admin/OfficeLetter/OfficeLetters")]
        public IActionResult OfficeLetters()
        {
            return View("OfficeLetter/OfficeLetters/Index");
        }
        #endregion

        #region NoteSheet
        [HttpGet("admin/OfficeLetter/NoteSheet")]
        public IActionResult NoteSheet()
        {
            return View("OfficeLetter/NoteSheet/Index");
        }
        #endregion

        #region OfficeLetterRemark
        [HttpGet("admin/OfficeLetter/OfficeLetterRemark")]
        public IActionResult OfficeLetterRemark()
        {
            return View("OfficeLetter/OfficeLetterRemark/Index");
        }

        [HttpGet("admin/OfficeLetter/OfficeLetterRemark/new")]
        public IActionResult NewOfficeLetterRemark()
        {
            return View("OfficeLetter/OfficeLetterRemark/NewOfficeLetterRemark");
        }
        #endregion

        #endregion

        #region Logs
        [HttpGet("admin/logs")]
        public IActionResult Logs()
        {
            return View("Logs/Index");
        }        
        #endregion
    }
}
