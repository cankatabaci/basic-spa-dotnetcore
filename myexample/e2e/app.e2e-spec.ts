import { MyexampleAngularPage } from './app.po';

describe('myexample-angular App', () => {
  let page: MyexampleAngularPage;

  beforeEach(() => {
    page = new MyexampleAngularPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
