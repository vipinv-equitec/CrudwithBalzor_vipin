using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class EditStudent
    {
        [Parameter]
        public string? id { get; set; }

        private BlazorApp.Models.Student? editedStudent;
        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(id) && int.TryParse(id, out int studentId))
            {
                editedStudent = await StudentService.GetStudentByIdAsync(studentId);
            }
            else
            {
                NavigationManager.NavigateTo("/error");
            }
        }
        private async Task UpdateStudent()
        {
            if (editedStudent != null)
            {
                await StudentService.EditStudentAsync(editedStudent);
            }
            NavigationManager.NavigateTo("/studentdata");
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
