using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.RecyclerView.Extensions;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace XamarinLaboratorinis5
{
    public class Fragment1 : Android.Support.V4.App.Fragment
    {
        public List<string> listViewItems = new List<string>();
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Fragment1, container, false);
            
            ListView listView = view.FindViewById<ListView>(Resource.Id.listView1);
            
            listViewItems.Add("Tekstas su A raidėmis");
            listViewItems.Add("Be ieškomo simbolio");
            listViewItems.Add("Čia yra ieškomas simbolis");
            listViewItems.Add("Nieko nebus");
            listViewItems.Add("Rasi ko ieškai");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(Context, Android.Resource.Layout.SimpleListItem1, objects: listViewItems.ToArray());

            listView.Adapter = adapter;

            listView.ItemClick += ListView_ItemClick;

            return view;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if(listViewItems[e.Position].Contains("A")
                || listViewItems[e.Position].Contains("a"))
            {

            }
        }
    }
}