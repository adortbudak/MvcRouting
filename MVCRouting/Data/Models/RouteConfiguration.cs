using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace MVCRouting.Data.Models
{
    public class RouteConfiguration
    {
        public int Id { get; set; }
        public string Culture { get; set; }
        public string RouteName { get; set; }
        public string Route { get; set; }
        public bool IsActive { get; set; }


        public int OneKeyServerId { get; set; }


        [ForeignKey("OneKeyServerId")]
        public virtual OneKeyServer OneKeyServer { get; set; }
    }
}