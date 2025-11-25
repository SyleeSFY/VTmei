using System.Net.Http.Json;

namespace Client.Core.Pages;

public partial class Contacts
{
    private Educator? educator;
    private bool isLoading = false;
    private string? errorMessage = null;
    
    private async Task GetEducator()
    {
        isLoading = true;
        errorMessage = null;
        StateHasChanged();
        
        try
        {
            educator = await Http.GetFromJsonAsync<Educator>("api/educators/1");
        }
        catch (Exception ex)
        {
            errorMessage = $"Не удалось загрузить данные: {ex.Message}";
        }
        finally
        {
            isLoading = false;
            StateHasChanged();
        }
    }
    
    public class Educator
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? AcademicDegree { get; set; }
    }
}