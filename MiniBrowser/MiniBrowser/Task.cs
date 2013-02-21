using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MiniBrowser
{
    public class Task
    {
        String name { get; set; }
        String description { get; set; }
        public Task(String name, String des)
        {
            this.name = name;
            this.description = des;
        }

    }
}
