namespace BlazorApp.Pages
{
    public partial class AddStudent
    {
        private BlazorApp.Models.Student newStudent = new BlazorApp.Models.Student();

        private async Task AddStud()
        {
            await StudentService.AddStudentAsync(newStudent);

            NavigationManager.NavigateTo("/studentdata");
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
