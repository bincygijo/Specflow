using KeyFramework.Global;
using KeyFramework.Pages;
using KeyFramework.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyFramework.Test
{
   public  class Sprint_1
    {
        [TestFixture]
        [Category("Sprint_1")]
        class Sprint_1_Administration : Base
        {
            [Test]
            public void ValidateProperty()
            {
                Property objProperty = new Property();
                objProperty.AddProperty();
            }

            [Test]
            public void ValidateDashboard()
            {
                //Creating object for property class 
                Property proObj = new Property();
                proObj.OwnerDashboard();
            }
            [Test]
            public void DeletePropertyData()
            {
                Property objProperty = new Property();
                objProperty.DeleteProperty();
            }

        }

    }
}
