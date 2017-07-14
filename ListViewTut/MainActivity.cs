using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
namespace ListViewTut
{
    [Activity(Label = "ListViewTut", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<DieGroup> mItems;
        private ListView mListView;
        private Button mButton;
        private MyListViewAdapter adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            //import from main.axml
            mListView = FindViewById<ListView>(Resource.Id.MyListView);
            mButton = FindViewById<Button>(Resource.Id.rollButton);
            mItems = new List<DieGroup>
            {
                new DieGroup(3, 6),
                new DieGroup(5, 8)
            };
            adapter = new MyListViewAdapter(this, mItems);
            
            mListView.Adapter = adapter;
            mListView.ItemClick += MListView_ItemClick;

            mButton.Click += MButton_Click;
        }

        private void MButton_Click(object sender, EventArgs e)
        {
            mItems.Add(new DieGroup(4,6));
            RunOnUiThread(() =>
            {
                adapter.NotifyDataSetChanged();
            });
            
        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].AddRolls());
        }
    }
}