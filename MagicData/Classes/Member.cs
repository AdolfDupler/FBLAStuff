using MagicData.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicData.Classes
{
    public class Member : IComparable<Member>
    {
        public static readonly string[] columns = { "MemberID", "FirstName", "LastName", "SchoolName", "State", "Email", "YearJoined", "Grade", "Active", "AmountOwed" };
        int MemberID;
        string FirstName, LastName;
        string SchoolName;
        string State;
        string Email;
        int YearJoined, Grade;
        bool active;
        double AmountOwed;
        public int compareKey = 0;

        

        public Member(AddMember form)
        {
            MemberID = form.MemberIDNum;
            FirstName = form.FirstName;
            LastName = form.LastName;
            SchoolName = form.SchoolName;
            State = form.StateName;
            Email = form.Email;
            active = form.Active;
            AmountOwed = form.AmountOwed;
            YearJoined = form.YearJoined;
            Grade = form.Grade;

            
        }
        public Member(ModMember form)
        {
            MemberID = form.MemberID;
            FirstName = form.FirstName;
            LastName = form.LastName;
            SchoolName = form.SchoolName;
            State = form.State;
            Email = form.Email;
            active = form.active;
            AmountOwed = form.AmountOwed;
            YearJoined = form.YearJoined;
            Grade = form.Grade;
        }
        public Member(object[] values)
        {
            if (values.Length != 10)
            {
                throw new Exception("INVALID ARRAY");

            }
            MemberID = (int)values[0];
            FirstName = values[1].ToString();
            LastName = values[2].ToString();
            SchoolName = values[3].ToString();
            State = values[4].ToString();
            Email = values[5].ToString();
            YearJoined = (int) values[6];
            Grade = (int)values[7];
            active = (bool) values[8];
            AmountOwed = Convert.ToDouble(values[9]);



        }
        public SqlCommand AddToSQL()
        {
            string snippet = "INSERT INTO Members VALUES (@MemberID, @FirstName, @LastName, @SchoolName, @State, @Email, @YearJoined, @Grade, @Active, @AmountOwed)";
            SqlCommand command = new SqlCommand(snippet);
            command.Parameters.Add("@MemberID", SqlDbType.Int).Value = MemberID;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            command.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = SchoolName;
            command.Parameters.Add("@State", SqlDbType.NVarChar).Value = State;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            command.Parameters.Add("@YearJoined", SqlDbType.Int).Value = YearJoined;
            command.Parameters.Add("@Grade", SqlDbType.Int).Value = Grade;
            command.Parameters.Add("@Active", SqlDbType.Bit).Value = active;
            command.Parameters.Add("@AmountOwed", SqlDbType.Money).Value = AmountOwed;
            return command;
        }
        
        public string toString()
        {
            string lad = MemberID + " " + FirstName + " " + LastName + " " + SchoolName + " " + State;
            return lad;
        }
        public ListViewItem ToListViewItem()
        {
            ListViewItem retrum = new ListViewItem(MemberID.ToString());
            retrum.SubItems.Add(FirstName);
            retrum.SubItems.Add(LastName);
            retrum.SubItems.Add(SchoolName);
            retrum.SubItems.Add(State);
            retrum.SubItems.Add(Email);
            retrum.SubItems.Add(YearJoined.ToString());
            retrum.SubItems.Add(Grade.ToString());
            retrum.SubItems.Add(active.ToString());
            retrum.SubItems.Add(AmountOwed.ToString("C"));
            
            return retrum;
        }

        public int CompareTo(Member other)
        {
            
            switch (compareKey )
            {
                case 0:
                    return MemberID.CompareTo(other.MemberID);
                case 1:
                    return FirstName.CompareTo(other.FirstName);
                case 2:
                    return LastName.CompareTo(other.LastName);
                case 3:
                    return SchoolName.CompareTo(other.SchoolName);
                case 4:
                    return State.CompareTo(other.State);
                case 5:
                    return Email.CompareTo(other.Email);
                case 6:
                    return YearJoined.CompareTo(other.YearJoined);
                case 7:
                    return Grade.CompareTo(other.Grade);
                case 8:
                    return active.CompareTo(other.active);
                case 9:
                    return AmountOwed.CompareTo(other.AmountOwed);
                default:
                    return 0;


                

            }
        }
        public void LoadIntoForm(ModMember form)
        {
            form.MemberID = MemberID;
            form.FirstName = FirstName;
            form.LastName = LastName;
            form.SchoolName = SchoolName;
            form.State = State;
            form.Email = Email;
            form.YearJoined = YearJoined;
            form.Grade = Grade;
            form.active = active;
            form.AmountOwed = AmountOwed;
        }
        public SqlCommand UpdateIntoSQL()
        {

            string snippet = "UPDATE Members SET FirstName = @FirstName, LastName = @LastName, SchoolName = @SchoolName, State=@State, Email=@Email, YearJoined=@YearJoined, Grade=@Grade, Active=@Active, AmountOwed=@AmountOwed WHERE MemberID = @MemberID;";
            SqlCommand command = new SqlCommand(snippet);
            command.Parameters.Add("@MemberID", SqlDbType.Int).Value = MemberID;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            command.Parameters.Add("@SchoolName", SqlDbType.NVarChar).Value = SchoolName;
            command.Parameters.Add("@State", SqlDbType.NVarChar).Value = State;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            command.Parameters.Add("@YearJoined", SqlDbType.Int).Value = YearJoined;
            command.Parameters.Add("@Grade", SqlDbType.Int).Value = Grade;
            command.Parameters.Add("@Active", SqlDbType.Bit).Value = active;
            command.Parameters.Add("@AmountOwed", SqlDbType.Money).Value = AmountOwed;
            
            return command;




        }
        
        
    }
}
