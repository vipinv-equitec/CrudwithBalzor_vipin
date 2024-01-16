using BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class DetailStudent
    {
        [Parameter] public int StudentId { get; set; }
        private StudentViewByIdResult? Student { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student = await StudentService.GetStudentByyIdAsync(StudentId);
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
