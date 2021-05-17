using CourseWork.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.IServices
{
    interface ICommentServise : IDisposable
    {
        Task AddComment(CommentDTO comment);
        Task EditComment(CommentDTO DTO);
        Task DeleteComment(int CommentId);
        Task<IEnumerable<CommentDTO>> GetByCampainId(int CampainId);
    }
}
