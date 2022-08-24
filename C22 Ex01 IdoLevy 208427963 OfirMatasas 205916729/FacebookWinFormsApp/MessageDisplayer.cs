using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class MessageDisplayer
    {
        public static void NoItemsAppearOnForm(string i_ItemsName)
        {
            MessageBox.Show(
                $"No {i_ItemsName} to retrieve :(",
                $"No {i_ItemsName}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void NoItemsPublishedOnRelevantTime(string i_TimeReference, string i_ItemsName)
        {
            MessageBox.Show(
                $"{i_TimeReference} you haven't published any {i_ItemsName}!",
                $"No {i_ItemsName} to show",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void InvalidTimePeriod(string i_TimePeriod)
        {
            MessageBox.Show(
                $"You can't choose a date from the {i_TimePeriod}!{Environment.NewLine}Please choose a valid date",
                "Invalid Time Period",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void CannotBeEmpty(string i_Action, string i_Item)
        {
            MessageBox.Show(
                $"Cannot {i_Action} an empty {i_Item}!",
                $"Empty {i_Item}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        internal static void ActionFailed(string i_Action)
        {
            MessageBox.Show(
                $"Failed on {i_Action}.",
                "Action Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        internal static void ActionSucceeded(string i_Message)
        {
            MessageBox.Show(
                i_Message,
                "Action succeeded",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
