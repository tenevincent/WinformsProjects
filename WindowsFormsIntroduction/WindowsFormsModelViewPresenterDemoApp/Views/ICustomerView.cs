﻿using System.Collections.Generic;

namespace FormsModelViewPresenter.View
{
    public interface ICustomerView
    {
        IList<string> CustomerList { get; set; }

        int SelectedCustomer { get; set; }

        string CustomerName { get; set; }

        string Address { get; set; }

        string Phone { get; set; }

        Presenter.CustomerPresenter Presenter { set; }
    }
}