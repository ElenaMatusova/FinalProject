using AutoMapper;
using CourseWork.BLL.DTOs;
using CourseWork.BLL.IServices;
using CourseWork.DAL.IRepositories;
using CourseWork.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.BLL.Services
{
    public class CommentServise : ICommentServise
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CommentServise(IUnitOfWork uow, IMapper mapper)
        {
            _unitOfWork = uow;
            _mapper = mapper;
        }
        public Task AddComment(CommentDTO commentDto)
        {
            var comment = _mapper.Map<CommentDTO, Comment>(commentDto);
            _unitOfWork.Comment.Create(comment);
            return _unitOfWork.Save();
        }

        public Task DeleteComment(int CommentDTOId)
        {
            _unitOfWork.Comment.Delete(CommentDTOId);
            return _unitOfWork.Save();
        }

        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }

        public Task EditComment(CommentDTO commentDto)
        {
            var comment = _mapper.Map<CommentDTO, Comment>(commentDto);
            _unitOfWork.Comment.Update(comment);
            return _unitOfWork.Save();
        }

        public async Task<IEnumerable<CommentDTO>> GetByCampainId(int CampainDTOId)
        {
            var comment = (await _unitOfWork.Comment.GetWhere(x => x.CampainId == CampainDTOId)).OrderByDescending(x => x.Date).ToList();
            return _mapper.Map<IEnumerable<Comment>, IEnumerable<CommentDTO>>(comment); 
        }
    }
}
