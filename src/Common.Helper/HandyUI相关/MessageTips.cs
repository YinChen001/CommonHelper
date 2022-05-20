using HandyControl.Data;
using System.Windows;
using MessageBox = HandyControl.Controls.MessageBox;

namespace Common.Helper
{
    public class MessageTips
    {
        /// <summary>
        /// 成功信息弹出框
        /// </summary>
        /// <param name="message"></param>
        public static void SuccessMessage(string message)
        {
            MessageBox.Show(new MessageBoxInfo
            {
                Message = message,
                Caption = "提示",
                Button = MessageBoxButton.OK,
                IconBrushKey = ResourceToken.SuccessBrush,
                IconKey = ResourceToken.SuccessGeometry,
                StyleKey = "MessageBoxCustom"
            });
        }
        /// <summary>
        /// 错误信息弹出框
        /// </summary>
        /// <param name="message"></param>
        public static void ErrorMessage(string message)
        {
            MessageBox.Show(new MessageBoxInfo
            {
                Message = message,
                Caption = "提示",
                Button = MessageBoxButton.OK,
                IconBrushKey = ResourceToken.DarkDangerBrush,
                IconKey = ResourceToken.ErrorGeometry,
                StyleKey = "MessageBoxCustom"
            });
        }
        /// <summary>
        /// 警告信息弹出框
        /// </summary>
        /// <param name="message"></param>
        public static void InfoMessage(string message)
        {
            MessageBox.Show(new MessageBoxInfo
            {
                Message = message,
                Caption = "提示",
                Button = MessageBoxButton.OK,
                IconBrushKey = ResourceToken.InfoBrush,
                IconKey = ResourceToken.InfoGeometry,
                StyleKey = "MessageBoxCustom"
            });
        }
        /// <summary>
        /// 确认取消信息弹出框
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MessageBoxResult AccentMessage(string message)
        {
            return MessageBox.Show(new MessageBoxInfo
            {
                Message = message,
                Caption = "提示",
                Button = MessageBoxButton.YesNo,
                IconBrushKey = ResourceToken.AccentBrush,
                IconKey = ResourceToken.AskGeometry,
                StyleKey = "MessageBoxCustom"
            });
        }
    }
}
