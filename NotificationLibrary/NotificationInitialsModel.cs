﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NotificationLibrary
{
    public class NotificationInitialsModel : NotificationModel
    {
        public string Initials { get; set; }
        public Color Color { get; set; }
    }
}