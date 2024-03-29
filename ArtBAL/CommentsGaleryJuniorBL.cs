﻿using ArtDL.Modelsa;
using ArtDL;
using ArtDTO.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtBL
{
    public class CommentsGaleryJuniorBL : ICommentsGaleryJuniorBL
    {
        private ICommentsGaleryJuniorDL commentsGaleryJuniorsDl;

        IMapper _mapper;

        public CommentsGaleryJuniorBL(ICommentsGaleryJuniorDL commentsGaleryJuniorsDl, IMapper mapper)
        {
            this.commentsGaleryJuniorsDl = commentsGaleryJuniorsDl;
            this._mapper = mapper;
        }

        public async Task<List<CommentsGaleryJuniorDTO>> GetCommentsgaleryjuniors()
        {
            try
            {
                List<CommentsGaleryJunior> res = await commentsGaleryJuniorsDl.GetCommentsGaleryJuniors();
                List<CommentsGaleryJuniorDTO> commentsGaleryJuniors = _mapper.Map<List<CommentsGaleryJuniorDTO>>(res);
                return commentsGaleryJuniors;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> AddCommentsgaleryjuniors(CommentsGaleryJuniorDTO commentsGaleryJuniorDTO)
        {
            try
            {

                CommentsGaleryJunior commentsGaleryJuniors = _mapper.Map<CommentsGaleryJunior>(commentsGaleryJuniorDTO);
                bool isAddCommentsgaleryjuniors = await commentsGaleryJuniorsDl.AddCommentsGaleryJuniors(commentsGaleryJuniors);
                return isAddCommentsgaleryjuniors;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public async Task<bool> RemoveCommentsgaleryjuniors(int commentsgaleryjuniorId)
        {
            try
            {
                //User user = _mapper.Map<User>(userId);
                bool isRemoveCommentsgaleryjuniors = await commentsGaleryJuniorsDl.RemoveCommentsGaleryJuniors(commentsgaleryjuniorId);
                return isRemoveCommentsgaleryjuniors;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
    }
    }

