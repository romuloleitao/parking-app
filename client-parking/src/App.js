import React from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';

import { Home } from './components/Home';
import { AddCar } from './components/AddCar';
import { EditCar } from './components/EditCar';

function App() {
  return (
    <div className="App">
    <Router>
      <Switch>
        <Route exact path="/" component={Home} />
        <Route path="/add" component={AddCar} />
        <Route path="/edit/:id" component={EditCar} />
      </Switch>
    </Router>
    </div>
  );
}

export default App;
