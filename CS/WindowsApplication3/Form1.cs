using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWizard;

namespace WindowsApplication3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
    }

    public class MyWizardControl: WizardControl {
        protected override WizardViewInfo CreateViewInfo() { 
            return new MyWizardViewInfo(this); 
        }
        
    }
    public class MyWizardViewInfo: WizardViewInfo {
        public MyWizardViewInfo(MyWizardControl w) : base(w) { }
        protected override WizardViewInfo.WizardModelBase CreateWizardModelCore(WizardStyle style) {
            if(style == WizardStyle.WizardAero) return new MyWizardAeroModel(this);
            return base.CreateWizardModelCore(style);
        }
    }
    public class MyWizardAeroModel: DevExpress.XtraWizard.WizardViewInfo.WizardAeroModel {
        public MyWizardAeroModel(MyWizardViewInfo v) : base(v) { }

        public override Rectangle GetContentBounds() {
            Rectangle rect = GetClientRectangle();
            rect.Y -= WizardAeroConsts.TitleBarHeight;
            rect.Height += WizardAeroConsts.TitleBarHeight;
            return rect;
        }

        public override Rectangle GetTitleBarBounds() {
            return Rectangle.Empty;
        }
    } 
}
