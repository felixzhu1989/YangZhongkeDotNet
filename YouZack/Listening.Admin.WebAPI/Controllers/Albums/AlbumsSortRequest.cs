using FluentValidation;

namespace Listening.Admin.WebAPI.Controllers.Albums
{
    public record AlbumsSortRequest
    {
        public Guid[] SortedAlbumIds { get; set; }
    }
    public class AlbumsSortRequestValidator:AbstractValidator<AlbumsSortRequest>
    {
        public AlbumsSortRequestValidator()
        {
            RuleFor(x => x.SortedAlbumIds).NotNull().NotEmpty()
                .NotContains(Guid.Empty).NotDuplicated();
        }
    }
}
