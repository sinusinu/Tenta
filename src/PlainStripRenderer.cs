using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenta {
    internal class PlainStripRenderer : ToolStripProfessionalRenderer {
        internal PlainStripRenderer() { }
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e) {
            //base.OnRenderToolStripBackground(e);  // get rid of gradient background
        }
    }
}
