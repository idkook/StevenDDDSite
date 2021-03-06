﻿namespace Steven.Domain.ViewModels
{
    public class UserRoleModel
    {
        public long Id { get; set; }

        public int Sort
        {
            get;
            set;
        }

        public string Remark
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string MenuIds { get; set; }
    }
}