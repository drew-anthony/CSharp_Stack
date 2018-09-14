using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RapperAPI.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;

        public ArtistController() {
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        //This method is shown to the user navigating to the default API domain name
        //It just display some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }
        [HttpGet("artists")]
        public JsonResult AllArtists()
        {
            return Json(allArtists);
        }
        [HttpGet("artists/name/{arts}")]
        public JsonResult ArtistsNameString(string arts) 
        {
            var artist = allArtists.Where(a => a.ArtistName.Contains($"{arts}"));
            return Json(artist);
        }
        [HttpGet("artists/realname/{real}")]
        public JsonResult ArtistsRealName(string real)
        {
            var artists = allArtists.Where( a => a.RealName.Contains($"{real}"));
            return Json(artists);
        }
        [HttpGet("artists/Hometown/{home}")]
        public JsonResult ArtistsHometown(string home)
        {
            var artists = allArtists.Where( a => a.Hometown == ($"{home}"));
            return Json(artists);
        }
        [HttpGet("artists/GroupId/{group}")]
        public JsonResult ArtistsGroupId(int group)
        {
            var artists = allArtists.Where( a => a.GroupId == group);
            return Json(artists);
        }
    }
}