using Android.App;
using Android.Widget;
using Android.OS;

namespace xamarin_calculator
{
    [Activity(Label = "xamarin_calculator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView answer;
        EditText num1, num2;
        Button add, sub, mul, div;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //call Id for Edit Text
            num1 = FindViewById<EditText>(Resource.Id.number1);
            num2 = FindViewById<EditText>(Resource.Id.number2);

            //Call Id for answer
            answer = FindViewById<TextView>(Resource.Id.ans);

            //Call Id for buttons
            add = FindViewById<Button>(Resource.Id.add_btn);
            sub = FindViewById<Button>(Resource.Id.sub_btn);
            mul = FindViewById<Button>(Resource.Id.mul_btn);
            div = FindViewById<Button>(Resource.Id.div_btn);

            //create Event handler

            add.Click += delegate {
                var a = num1.Text;
                var b = num2.Text;
                //check the values are null / not null
                if (num1.Text != "" && num2.Text != "")
                {
                    answer.Text = "" + (double.Parse(a) + double.Parse(b));
                }
                else
                {
                    Toast.MakeText(this, "Please Enter the values", ToastLength.Long).Show();
                }
            };

            sub.Click += delegate {
                var a = num1.Text;
                var b = num2.Text;
                //check the values are null / not null
                if (num1.Text != "" && num2.Text != "")
                {
                    answer.Text = "" + (double.Parse(a) - double.Parse(b));
                }
                else
                {
                    Toast.MakeText(this, "Please Enter the values", ToastLength.Long).Show();
                }
            };

            mul.Click += delegate {
                var a = num1.Text;
                var b = num2.Text;
                //check the values are null / not null
                if (num1.Text != "" && num2.Text != "")
                {
                    answer.Text = "" + (double.Parse(a) * double.Parse(b));
                }
                else
                {
                    Toast.MakeText(this, "Please Enter the values", ToastLength.Long).Show();
                }
            };


            div.Click += delegate {
                var a = num1.Text;
                var b = num2.Text;
                //check the values are null / not null
                if (num1.Text != "" && num2.Text != "")
                {
                    answer.Text = "" + (double.Parse(a) / double.Parse(b));
                }
                else
                {
                    Toast.MakeText(this, "Please Enter the values", ToastLength.Long).Show();
                }
            };
        }
    }
}

