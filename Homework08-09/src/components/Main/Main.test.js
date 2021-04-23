/* global describe, it, expect, mount */
import React from 'react';
import Main from './Main';
import { MemoryRouter } from 'react-router';
import { Message } from 'semantic-ui-react'
import Login from '../Login';

const setup = (path) => {
  const component = mount(
    <MemoryRouter initialEntries={[path]}>
      <Main />
    </MemoryRouter>
  );

  return {
    component,
  }
}

describe('Main', () => {
  it('should render page not found', () => {
    const { component } = setup('/asdf');
    expect(component.find(Message)).toHaveLength(1);
  });

  it('should render landing page', () => {
    const { component } = setup('/');
    expect(component.find(Login)).toHaveLength(1);
  });

  it('should render login page', () => {
    const { component } = setup('/login');
    expect(component.find(Login)).toHaveLength(1);
  });
});
