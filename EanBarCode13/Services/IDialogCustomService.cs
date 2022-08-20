namespace EanBarCode13.Services
{
    public interface IDialogCustomService
    {
        Task<string> DisplayActionSheet(string title, string cancel, string destruction, FlowDirection flowDirection, params string[] buttons);
        Task<string> DisplayActionSheet(string title, string message, string accept, string cancel);
        Task<bool> DisplayConfirm(string title, string message, string accept, string cancel);
    }
}