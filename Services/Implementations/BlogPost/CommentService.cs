using Movie_Ticket_Booking_Backend.Domain.Blogs;
using Movie_Ticket_Booking_Backend.DTOs.Blog;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.BlogPost;
using Movie_Ticket_Booking_Backend.Services.Interfaces.BlogPost;

namespace Movie_Ticket_Booking_Backend.Services.Implementations.BlogPost
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<List<CommentDto>> GetCommentsByPostId(string blogPostId)
        {
            return await _commentRepository.GetCommentsByPostId(blogPostId);
        }

        public async Task CreateComment(string blogPostId, CreateCommentRequestDto request, string userId)
        {
            var comment = new Comment
            {
                CommentId = Guid.NewGuid().ToString(),
                BlogPostId = blogPostId,
                UserId = userId,
                Content = request.Content,
                CreatedDate = DateTime.UtcNow
            };

            await _commentRepository.AddComment(comment);
        }
    }
}
