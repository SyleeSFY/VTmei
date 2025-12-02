using System.Net.Http.Json;
using Client.Core.Shared.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
    private void GoToEducatorCard()
    {
        string id = "2";
        if (educator != null)
        {
            Navigation.NavigateTo($"/EducatorCard/{id}");
        }
    }
}