/// <reference path="../jasmine-resharper-template-testing/ClientTemplates/string-templates.js"/>

describe('something', function () {
    it('does something great', function () {
        console.log(template);
    });
});

// uncomment line below to debug tests in dev console
jasmine.getEnv().currentRunner_.finishCallback = function () { };