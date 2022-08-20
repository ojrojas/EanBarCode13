namespace EanBarCode13.Services
{
    public class DialogCustomService : IDialogCustomService
    {
        public async Task<bool> DisplayConfirm(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        public async Task<string> DisplayActionSheet(string title, string cancel, string destruction, FlowDirection flowDirection, params string[] buttons)
        {
            return await Application.Current.MainPage.DisplayActionSheet(title, cancel, destruction, flowDirection, buttons);
        }

        public async Task<string> DisplayActionSheet(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayPromptAsync(title, message, accept, cancel);
        }
    }
}
