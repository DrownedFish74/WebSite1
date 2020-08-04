﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using w2.Common.Web;

public partial class Complete : System.Web.UI.Page
{
	/// <summary>
	/// ページロード
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
	{
		var ht = (Hashtable)Session["param"];
		if (ht== null) return;

		lRedirect1.Text = HtmlSanitizer.HtmlEncode(ht["value1"]);
		lRedirect2.Text = HtmlSanitizer.HtmlEncode(ht["value2"]);
    }
}