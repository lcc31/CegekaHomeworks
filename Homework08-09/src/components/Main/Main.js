import React, { Component } from 'react';
import { Switch, Route } from 'react-router';
import { AlbumList } from '../Album';
import { PhotoList } from '../Photo';
import Login from '../Login';
import { Message } from 'semantic-ui-react'

class Main extends Component {
  renderError() {
    return (
      <Message
        icon="warning circle"
        header="Ups... Page Not Found"
        content="Our engineers didn't found what your are looking for, please try again!"
      />
    );
  }

  render() {
    return (
      <Switch>
        <Route exact path="/" component={Login} />
        <Route path="/albums" component={AlbumList} />
        <Route path="/photos" component={PhotoList} />
        <Route path="/login" component={Login} />
        <Route render={this.renderError} />
      </Switch>
    );
  }
}

export default Main;
