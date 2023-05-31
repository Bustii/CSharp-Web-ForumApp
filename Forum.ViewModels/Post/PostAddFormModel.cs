using System.ComponentModel.DataAnnotations;

namespace Forum.ViewModels.Post
{
    using static Forum.Common.Validations.EntityValidations.Post;
    public class PostAddFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
