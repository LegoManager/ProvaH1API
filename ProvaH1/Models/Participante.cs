using System.ComponentModel.DataAnnotations;
using ProvaH1.Validation;

namespace ProvaH1.Models
{
    public class Participante
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Insira o nome do participante")]
        [MinLength(3, ErrorMessage = "Nome precisa possuir mais de 2 letras")]
        [MaxLength(255, ErrorMessage = "Caracteres em excesso")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Insira a descrição do que irá levar")]
        public string Carne { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor, insira a idade")]
        [AgeValidation(ErrorMessage = "Participantes maiores de 18 anos não são permitidos")]
        public int Idade { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Insira a descrição do que irá levar")]
        public string Bebida { get; set; }
    }
}
