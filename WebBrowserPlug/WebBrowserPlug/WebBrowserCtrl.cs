using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thyt.TiPLM.Common.Interface.Addin;
using Thyt.TiPLM.Common.Interface.Environment;
using Thyt.TiPLM.UIL.Controls;
using Thyt.TiPLM.Common;

namespace WebBrowserPlug {
    public partial class WebBrowserCtrl : UserControlPLM, IInnerBrowser, IAddinClientEntry {
        public WebBrowserCtrl() {
            this.components = null;
            InitializeComponent();
        }
        protected override void Dispose(bool disposing) {
            try {
                this.webBrowser1.Dispose();
            } catch {
            }
            if (disposing && (this.components != null)) {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// 初始化浏览器
        /// </summary>
        public void InitBrowser() {

        }
        /// <summary>
        ///  将浏览器加入到控件中。
        /// </summary>
        /// <param name="ctrl"></param>
        public void AddControl(Control ctrl) {
            ctrl.Controls.Add(this);
            this.Dock = DockStyle.Fill;
            base.Visible = true;
        }
        /// <summary>
        /// 验证是否允许批注
        /// </summary>
        /// <returns>是否允许批注</returns>
        public bool CanMarkup() {
            return false;
        }

        /// <summary>
        /// 进入批注模式
        /// </summary>
        /// <param name="fileFullName">文件全路径名</param>
        /// <param name="mkPath">批注路径</param>
        /// <param name="mkName">批注文件名</param>
        /// <param name="allowMarkup">是否允许使用批注工具</param>
        public void EnterMarkupMode(string fileFullName, string mkPath, string mkName, bool allowMarkup) {
        }
        /// <summary>
        /// 退出批注模式
        /// </summary>
        /// <returns>批注全路径（带批注文件名）</returns>
        public string ExitMarkupMode() {
            return null;
        }
        /// <summary>
        /// 后续处理
        /// </summary>
        public void Finalize() {
            int i = 0;
        }

        /// <summary>
        /// 是否需要浏览器池
        /// </summary>
        /// <returns></returns>
        public bool IsNeedPool() {
            return true;
        }
        /// <summary>
        /// 贴图
        /// </summary>
        /// <param name="path">要贴图的图纸文件路径</param>
        /// <param name="obj">传递的参数</param>
        public void PastePicFile(string path, object obj) {
        }
        /// <summary>
        /// 图纸打印
        /// </summary>
        /// <param name="path">打印路径</param>
        public void PrintFile(string path) {
        }
        /// <summary>
        /// 设置要删除文件的路径。
        /// </summary>
        /// <param name="dir"></param>
        public void SetDeletedDir(string dir) {
            base.Tag = dir;
        }
        /// <summary>
        /// 设置浏览器的显示规则
        /// </summary>
        /// <param name="rule"></param>
        //  horace 050816
        public void SetDisplayRule(BrowserDisplayRule rule) {
        }
        /// <summary>
        /// 设置要浏览的源文件路径。
        /// </summary>
        /// <param name="filePath"></param>
        public void SetSourceFile(string filePath) {
            this.webBrowser1.Navigate(filePath);
        }
        /// <summary>
        /// 设置浏览器是否可见。
        /// </summary>
        /// <param name="visible"></param>
        public void SetVisible(bool visible) {
            base.Visible = visible;
        }
    }
}
