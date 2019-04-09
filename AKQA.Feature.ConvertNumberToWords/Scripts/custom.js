jQuery(document).ready(function () {    

    jQuery("#convertButton").click(function () {

        jQuery(".label-danger").hide();
        jQuery(".label-danger").text("");

        // Validate name textbox
        var name = jQuery("input[name='name'").val();
        if (name == '') {

            jQuery("#labelName").text("Please enter your name");
            jQuery("#labelName").show();
            jQuery(".label-success").text('');
            jQuery(".label-success").hide();
            jQuery("input[name='name'").focus();
            return false;

        }

        // Validate number textbox
        var numb = jQuery("input[name='number'").val();
        var reg = /^-?[+]?[0-9]+([.][0-9]{1,2})?$/;

        if (numb == "" || !reg.test(numb)) {

            jQuery("#labelNumber").text("Please enter a valid number");
            jQuery("#labelNumber").show();
            jQuery(".label-success").text('');
            jQuery(".label-success").hide();
            jQuery("input[name='number'").focus();

            return false;
        } else {
            jQuery(".label-warning").show();
            $.ajax({         
                // Call api
                url: "api/numbertowords/convertnumbertowords/" + numb + "/",
                type: "get",
                contentType: "application/json",
                dataType: "json",                
                success: function (response) {
                    jQuery(".label-success").show();
                    jQuery(".label-warning").hide();
                    jQuery(".label-success").text(name + ' - "' + response + '"');
                }
            });


        }

    });
})