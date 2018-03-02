using System;

namespace Demo.Views.MasterDetailPage
{

    public class MasterDetailHomeMenuItem
    {
        public MasterDetailHomeMenuItem()
        {
            TargetType = typeof(MasterDetailHomeDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}