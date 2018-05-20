using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Common.RequestModel;
using Common.ViewModel;
using Model;

namespace RequestModel
{
    public class CourseRequestModel:BaseRequestModel<Course>
    {
        //public CourseRequestModel() :base("")
        //{
            
        //}
        public CourseRequestModel(string keyword, string orderBy = "Modified", string isAscending = "false") : base(keyword, orderBy, isAscending)
        {
        }

        protected override Expression<Func<Course, bool>> GetExpression()
        {
            Keyword = Keyword.ToLower();
            ExpressionObj = x => x.Name.Contains(Keyword) || x.Topic.Contains(Keyword);
            ExpressionObj =ExpressionObj.And(GenerateBaseEntityExpression());
            return ExpressionObj;
        }

        public override Expression<Func<Course, DropDownViewModel>> Dropdown()
        {
            return x => new DropDownViewModel() {Id = x.Id, Text = x.Name, Data = x};
        }
    }
}
