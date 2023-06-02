using SeuCeva.App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCeva.App.Shared.Components.CtaHome
{
    public partial class CtaHome
    {
        public List<CtaHomeService> cta { get; set; }

        public CtaHome()
        { 
            cta = new List<CtaHomeService>();
            cta.Add(new CtaHomeService()
            {
                Img = "/images/ctas/cta-1.jpg"
            });

            cta.Add(new CtaHomeService()
            {
                Img = "/images/ctas/cta-2.jpg"
            });

            cta.Add(new CtaHomeService()
            {
                Img = "/images/ctas/cta-3.jpg"
            });

            cta.Add(new CtaHomeService()
            {
                Img = "/images/ctas/cta-4.jpg"
            });

        }
    }
}
