﻿namespace Forum.Web.ViewModels.Threads
{
    using Forum.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    public class ThreadViewModel
    {
        public static Expression<Func<Thread, ThreadViewModel>> FromThread
        {
            get
            {
                return thread => new ThreadViewModel
                {
                    Id = thread.Id,
                    Title = thread.Title,
                    Content = thread.Content,
                    Username = thread.User.UserName
                };
            }
        }

        public long Id { get; set; }

        public string Title { get; set; }

        public string Username { get; set; }

        public string Content { get; set; }
    }
}