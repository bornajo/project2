﻿using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    public class CommonService : BaseService<Student>
    {
        public CommonService() : base(string.Empty)
        {
        }
        protected override void DisplayList(IEnumerable<Student> list)
        {
            throw new NotImplementedException();
        }
        protected override Student AddSpecific(Student model)
        {
            throw new NotImplementedException();
        }
        public new IEnumerable<Student> FindAll()
        {
            return base.FindAll();
        }
        protected override void DisplaySingle(Student model)
        {
            throw new NotImplementedException();
        }
    }
}