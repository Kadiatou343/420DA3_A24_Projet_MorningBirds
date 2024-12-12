using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Utilities.Presentation;
public static class SelectorExtensions {

    /// <summary>
    /// Refreshes the display of the elements of the <see cref="ComboBox"/>.
    /// </summary>
    /// <param name="combobox"></param>
    public static void RefreshDisplay(this ComboBox combobox) {
        List<object> items = new List<object>();
        foreach (object item in combobox.Items) { 
            items.Add(item);
        }
        object selectedItem = combobox.SelectedItem;
        combobox.Items.Clear();
        foreach (object item in items) {
            _ = combobox.Items.Add(item);
        }
        combobox.SelectedItem = selectedItem;
    }

    /// <summary>
    /// Refreshes the display of the elements of the <see cref="ListBox"/>.
    /// </summary>
    /// <param name="listbox"></param>
    public static void RefreshDisplay(this ListBox listbox) {
        List<object> items = new List<object>();
        foreach (object item in listbox.Items) {
            items.Add(item);
        }
        List<object> selectedItems = new List<object>();
        foreach (object item in listbox.SelectedItems) {
            selectedItems.Add(item);
        }

        listbox.SelectedItems.Clear();
        listbox.Items.Clear();
        foreach (object item in items) {
            _ = listbox.Items.Add(item);
        }
        foreach (object item in selectedItems) {
            listbox.SelectedItems.Add(item);
        }
    }
}
