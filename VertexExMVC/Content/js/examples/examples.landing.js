/*
Name: 			Landing Page - Examples
Written by: 	Bootstrap Templates - (http://www.bootstraptemplates.net)
Theme Version:	1.0.0
*/

/* 
* Color Picker
*/
(function( $ ) {

	'use strict';

	$('.colorpicker-element').each(function(){
		var input = $(this).find('input');

		input.parent().colorpicker();
	});

}).apply( this, [ jQuery ]);