using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_server.BusinesLogic.Core.Models
{
    public partial class UserInformationBlo : Component
    {
        public UserInformationBlo()
        {
            InitializeComponent();
        }

        public UserInformationBlo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
