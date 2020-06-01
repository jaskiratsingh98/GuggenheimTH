import { AppPage } from './app.po';
import { element, by, browser } from 'protractor';

describe('App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('testing value calculation', () => {
    page.navigateTo();
    element(by.name('starttime')).sendKeys('05:31', 'PM');
    element(by.name('minsAbove6')).sendKeys(5);
    element(by.name('milesBelow6')).sendKeys(2);
    element(by.name('date')).sendKeys('05/01/2020');

    element(by.id('submitButton')).click();

    expect(element(by.className('result-line')).getText()).toEqual('The cost of the trip is $9.75.');
  });
});
