using Prism.Services.Dialogs;
using System.Windows;

namespace Common.Helper
{
    public class WinEditHelper
    {
        private readonly IDialogService _dialogService;

        public WinEditHelper(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        /// <summary>
        /// 执行编辑弹窗（一个实体）
        /// </summary>
        /// <param name="entity">接收的实体</param>
        /// <param name="title">弹窗标题</param>
        /// <param name="address">弹窗对应的地址</param>
        /// <param name="messageInfo">保存成功提示信息</param>
        public void ExecuteEidt(object? entity, string title, string address, string messageInfo)
        {
            DialogParameters param = new();
            param.Add("Title", title);
            param.Add("Entity", entity);
            _dialogService.ShowDialog(address, param, r =>
            {
                if (r.Result == ButtonResult.OK)
                {
                    MessageBox.Show(messageInfo);
                }
            });

        }

        /// <summary>
        /// 执行编辑弹窗（两个实体）
        /// </summary>
        /// <param name="fristEntity">接收的第一个实体</param>
        /// <param name="secondEntity">接收的第二个实体</param>
        /// <param name="title">弹窗标题</param>
        /// <param name="address">弹窗对应的地址</param>
        /// <param name="messageInfo">保存成功提示信息</param>
        public void ExecuteEidt(object? fristEntity, object? secondEntity, string title, string address, string messageInfo)
        {
            DialogParameters param = new();
            param.Add("Title", title);
            param.Add("FristEntity", fristEntity);
            param.Add("SecondEntity", secondEntity);
            _dialogService.ShowDialog(address, param, r =>
            {
                if (r.Result == ButtonResult.OK)
                {
                    MessageBox.Show(messageInfo);
                }
            });

        }
    }
}
