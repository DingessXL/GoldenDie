using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.ObjectModel;

namespace ListViewTut
{
    class MyListViewAdapter : BaseAdapter<DieGroup>
    {
        private List<DieGroup> mItems;
        private Context mContext;

        public MyListViewAdapter(Context context, List<DieGroup> items)
        {
            mItems = items;
            mContext = context;
        }

        //overrides for baseadapter methods
        public override int Count
        {
            get { return mItems.Count; }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override DieGroup this[int position]
        {
            get { return mItems[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if(row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listview_row, null, false);
            }

            TextView txtFirst = row.FindViewById<TextView>(Resource.Id.rollSum);
            txtFirst.Text = mItems[position].AddRolls().ToString();
            TextView txtLast = row.FindViewById<TextView>(Resource.Id.rollBreakdown);
            txtLast.Text = mItems[position].ToString();
            return row;
        }
    }
}