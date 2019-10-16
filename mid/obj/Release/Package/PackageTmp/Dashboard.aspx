<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="mid.Dashboard" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
   
    <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>لوحة التحكم | InfoSAS</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="rtl-dashboard-v2-master/css/style.css"/>
    <link rel="stylesheet" type="text/css" href="rtl-dashboard-v2-master/js/map/jqvmap.min.css"/>
</head>
<body>
    <div class="container-fluid">
    <div class="row">
    <div class="col-xl-10 col-lg-10 col-md-12 col-sm-12">
            <div class="alert alert-dismissible alert-success text-right direction-rtl" role="alert">
                <button type="button" class="close" data-dismiss="alert">&times;</button>
                <strong>تم التحديث</strong>.
            </div>
            <div class="row direction-rtl mt-2">
                <div class="col-sm-12">
                    <h2 class="text-right text-primary">الرئيسية</h2>
                    <hr class="bg-info">
                </div>
                <div class="col-xl-3 col-lg-6 col-md-6 col-sm-12 mt-1">
                    <div class="card">
                        <div class="card-body p-0">
                            <div class="row">
                                <div class="col-xl-7 col-lg-6 col-md-6 col-6 text-right h-auto">
                                    <h5 class="mt-2 mr-2">عدد العملاء</h5>
                                    <h5 class="mt-2 mr-3 font-weight-bold">100</h5>
                                </div>
                                <div class="col-xl-5 col-lg-6 col-md-6 col-6 h-auto">
                                    <div class="text-center bg-info">
                                        <i class="fa fa-shopping-bag fa-4x align-middle pt-3 pb-3"></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-lg-6 col-md-6 col-sm-12 mt-1">
                    <div class="card">
                        <div class="card-body p-0">
                            <div class="row">
                                <div class="col-xl-7 col-lg-6 col-md-6 col-6 text-right h-auto">
                                    <h5 class="mt-2 mr-2">عدد الموردين</h5>
                                    <h5 class="mt-2 mr-3 font-weight-bold">100</h5>
                                </div>
                                <div class="col-xl-5 col-lg-6 col-md-6 col-6 h-auto">
                                    <div class="text-center bg-warning">
                                        <i class="fa fa-user fa-4x align-middle p-3"></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-lg-6 col-md-6 col-sm-12 mt-1">
                    <div class="card">
                        <div class="card-body p-0">
                            <div class="row">
                                <div class="col-xl-7 col-lg-6 col-md-6 col-6 text-right h-auto">
                                    <h5 class="mt-2 mr-2">الأصناف</h5>
                                    <h5 class="mt-2 mr-3 font-weight-bold">100</h5>
                                </div>
                                <div class="col-xl-5 col-lg-6 col-md-6 col-6 h-auto">
                                    <div class="text-center bg-danger">
                                        <i class="fa fa-th-large fa-4x align-middle pt-3 pb-3"></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-3 col-lg-6 col-md-6 col-sm-12 mt-1">
                    <div class="card">
                        <div class="card-body p-0">
                            <div class="row">
                                <div class="col-xl-7 col-lg-6 col-md-6 col-6 text-right h-auto">
                                    <h5 class="mt-2 mr-2">الموظفين</h5>
                                    <h5 class="mt-2 mr-3 font-weight-bold">100</h5>
                                </div>
                                <div class="col-xl-5 col-lg-6 col-md-6 col-6 h-auto">
                                    <div class="text-center bg-success">
                                        <i class="fa fa-comments fa-4x align-middle pt-3 pb-3"></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12 mt-1 mb-1">
                    <div class="card">
                        <div class="card-header text-right">
                            لوحة العرض
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-hover table-striped p-2">
                                    <thead class="thead-dark text-center">
                                    <tr>
                                        <th>رقم الموظف</th>
                                        <th>الاسم</th>
                                        <th>التاریخ</th>
                                        <th>الحالة</th>
                                        <th>مشاهدة</th>
                                    </tr>
                                    </thead>
                                    <tbody class="text-center">
                                    <tr>
                                        <td class="align-middle">156789</td>
                                        <td class="align-middle">InfoSAS</td>
                                        <td class="align-middle">1397/09/01</td>
                                        <td class="align-middle"><span class="badge badge-success p-2 w-100">ارسال شد</span></td>
                                        <td class="align-middle"><a href="#">مشاهدة</a></td>
                                    </tr>
                                    <tr>
                                        <td class="align-middle">156789</td>
                                        <td class="align-middle">حامد حقی</td>
                                        <td class="align-middle">1397/09/01</td>
                                        <td class="align-middle"><span class="badge badge-info p-2 w-100">در حال بررسی</span></td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    <tr>
                                        <td class="align-middle">156789</td>
                                        <td class="align-middle">حامد حقی</td>
                                        <td class="align-middle">1397/09/01</td>
                                        <td class="align-middle"><span class="badge badge-danger p-2 w-100">عدم ارسال</span></td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    <tr>
                                        <td class="align-middle">156789</td>
                                        <td class="align-middle">حامد حقی</td>
                                        <td class="align-middle">1397/09/01</td>
                                        <td class="align-middle"><span class="badge badge-primary p-2 w-100">عدم ارسال</span></td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    <tr>
                                        <td class="align-middle">156789</td>
                                        <td class="align-middle">حامد حقی</td>
                                        <td class="align-middle">1397/09/01</td>
                                        <td class="align-middle"><span class="badge badge-secondary p-2 w-100">عدم ارسال</span></td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                  
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-md-12 col-sm-12 mt-1 mb-1">
                    <div class="card">
                        <div class="card-header text-right">
                            لوحة العرض
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-hover table-striped">
                                    <thead class="thead-dark text-center">
                                    <tr>
                                       
                                        <th>الرقم</th>
                                        <th>تاریخ </th>
                                        <th>ایمیل</th>
                                        <th>مشاهدة</th>
                                    </tr>
                                    </thead>
                                    <tbody class="text-center">
                                    <tr>
                                        
                                        <td class="align-middle">hamed07</td>
                                        <td class="align-middle">1397/01/02</td>
                                        <td class="align-middle">hamedhaghi07@gmail.com</td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    <tr>
                                      
                                        <td class="align-middle">hamed07</td>
                                        <td class="align-middle">1397/01/02</td>
                                        <td class="align-middle">hamedhaghi07@gmail.com</td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    <tr>
                                       
                                        <td class="align-middle">hamed07</td>
                                        <td class="align-middle">1397/01/02</td>
                                        <td class="align-middle">hamedhaghi07@gmail.com</td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    <tr>
                                      
                                        <td class="align-middle">hamed07</td>
                                        <td class="align-middle">1397/01/02</td>
                                        <td class="align-middle">hamedhaghi07@gmail.com</td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    <tr>
                                        
                                        <td class="align-middle">hamed07</td>
                                        <td class="align-middle">1397/01/02</td>
                                        <td class="align-middle">hamedhaghi07@gmail.com</td>
                                        <td class="align-middle"><a href="#">مشاهده</a></td>
                                    </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>               
            </div>       
        </div>
        </div>
        </div>
</body>
</html>

</asp:Content>


