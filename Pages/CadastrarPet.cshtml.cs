using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AMS_TIMETCC_PET.Pages;

    public class CadastrarPetModel : PageModel
    {
        private readonly ILogger<CadastrarPetModel> _logger;

        public CadastrarPetModel(ILogger<CadastrarPetModel> logger)
        {
            _logger = logger;
        }
    }

