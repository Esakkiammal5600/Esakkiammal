$(document).ready(function () {
    //date picker
    $(".date-picker").datepicker({
        showOn: "button",
        changeMonth: true,
        changeYear: true,
        //buttonImage: "http://jqueryui.com/resources/demos/datepicker/images/calendar.gif",
        buttonImage:"/Images/icons8-calendar-50.png",
        buttonImageOnly: true,

    });

    $("#txt_dob").click(function () {
        $("#txt_dob").datepicker('show');
    });

    $("#txt_course_from").click(function () {
        $("#txt_course_from").datepicker('show');
    });

    $("#txt_course_to ").click(function () {
        $("#txt_course_to").datepicker('show');
    });

    $("#txt_initiation_date").click(function () {
        $("#txt_initiation_date").datepicker('show');
    });

    $("#txt_amc_from").click(function () {
        $("#txt_amc_from").datepicker('show');
    });

    $("#txt_amc_to").click(function () {
        $("#txt_amc_to").datepicker('show');
    });

    $("#txt_amc_from1").click(function () {
        $("#txt_amc_from1").datepicker('show');
    });

    $("#txt_amc_to1").click(function () {
        $("#txt_amc_to1").datepicker('show');
    });

    $("#txt_amc_from2").click(function () {
        $("#txt_amc_from2").datepicker('show');
    });

    $("#txt_amc_to2").click(function () {
        $("#txt_amc_to2").datepicker('show');
    });

    $("#txt_ssy_from1").click(function () {
        $("#txt_ssy_from1").datepicker('show');
    });

    $("#txt_ssy_to1").click(function () {
        $("#txt_ssy_to1").datepicker('show');
    });

    $("#txt_ssy_from2").click(function () {
        $("#txt_ssy_from2").datepicker('show');
    });

    $("#txt_ssy_to2").click(function () {
        $("#txt_ssy_to2").datepicker('show');
    });

    $("#txt_addcourse_from_1").click(function () {
        $("#txt_addcourse_from_1").datepicker('show');
    });
    $("#txt_addcourse_to_1").click(function () {
        $("#txt_addcourse_to_1").datepicker('show');
    });
    $("#txt_addcourse_from_2").click(function () {
        $("#txt_addcourse_from_2").datepicker('show');
    });
    $("#txt_addcourse_to_2").click(function () {
        $("#txt_addcourse_to_2").datepicker('show');
    });
    $("#txt_addcourse_from_3").click(function () {
        $("#txt_addcourse_from_3").datepicker('show');
    });
    $("#txt_addcourse_to_3").click(function () {
        $("#txt_addcourse_to_3").datepicker('show');
    });

    $("#txt_date1").click(function () {
        $("#txt_date1").datepicker('show');
    });
    $("#txt_remark_date").click(function () {
        $("#txt_remark_date").datepicker('show');
    });
    $("#txt_oathceremdate").click(function () {
        $("#txt_oathceremdate").datepicker('show');
    });


    
    
    //Default checked radio button
    $("#rb_male").prop("checked", true);
    $("#rb_married").prop("checked", true);

    $("#rb_yes_note").prop("checked", true);
    $("#rb_yes_certificate").prop("checked", true);
    $("#rb_yes_photo").prop("checked", true);

    $('#cb_confirm').prop('checked', true);

    //add course
    $("#add_course").click(function () {
        $.ajax({
            type: "GET",
            url: 'CourseRegistration/AddMultipleCourse',
            success: function (response) {
                console.log(response);
                $(".div-course").append(response);
            },
            error: function () {
                alert("Error occured!!")
            }
        });  
        //if ($("#add_course_1").css('display') == "flex" && $("#add_course_2").css('display') == "none") {
        //    $("#add_course_2").show();
        //}
        //else if ($("#add_course_1").css('display') == "flex" && $("#add_course_2").css('display') == "flex") {
        //    $("#add_course_3").show();
        //}
        //else {
        //    $("#add_course_1").show();
        //}
    });

    $("#btn_submit").click(function () {
        if ($("#form").valid()) {
            $.ajax({
                type: "GET",
                url: 'CourseRegistration/GetDetails',
                success: function (response) {
                    console.log(response);

                },
                error: function () {
                    alert("Error occured!!")
                }
            });
        }
        else {

        }

    })

    //cancel course

    $("#cancel_add_course_1").click(function () {
        $("#add_course_1").hide();
    });
    //$("#cancel_add_course_2").click(function () {
    //    $("#add_course_2").hide();
    //});
    //$("#cancel_add_course_3").click(function () {
    //    $("#add_course_3").hide();
    //});

});

