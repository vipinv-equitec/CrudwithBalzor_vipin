using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class Student
    {
        private List<BlazorApp.Models.StudentViewAllResult>? Studlists;

        protected override async Task OnInitializedAsync()
        {
            Studlists = await StudentService.GetStudentData();
        }
        public void NavigateToAddStudent()
        {
            NavigationManager.NavigateTo("/addStudent");
        }
        public void OnEditClicked(int id)
        {
            NavigationManager.NavigateTo($"/editStudent/{id}");
        }
        public void OnDetailsClicked(int id)
        {
            NavigationManager.NavigateTo($"/detailstudent/{id}");
        }
        public async Task OnDeleteClicked(int id)
        {
            await StudentService.DeleteStudentAsync(id);
            NavigationManager.NavigateTo(NavigationManager.Uri,forceLoad:true);
        }
        public void NavigateToDeleteStudent()
        {
            NavigationManager.NavigateTo("/deletedStudent");
        }
    }
}
