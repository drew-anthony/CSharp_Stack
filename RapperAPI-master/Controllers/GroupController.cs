using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RapperAPI.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        List<Artist> allArtists {get; set;}
        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
            allArtists = JsonToFile<Artist>.ReadJson();
        }
        [HttpGet("groups")]
        public JsonResult GroupsGroupId()
        {
            return Json(allGroups);
        }
        [HttpGet("groups/Name/{group}")]
        public JsonResult GroupsGroupId(string group)
        {
            var groups = allGroups.Where( g => g.GroupName.Contains($"{group}"));
            return Json(groups);
        }
        [HttpGet("groups/GroupId/{group}")]
        public JsonResult GroupID(int group)
        {
            var groups = allGroups.Where( g => g.Id == group);
            if(groups != null)
            {
                var artists = from g in groups join a in allArtists on g.Id equals a.GroupId group a by g.GroupName into g select new {g};
                return Json(artists);
            }
            return Json(groups);
        }
    }
}