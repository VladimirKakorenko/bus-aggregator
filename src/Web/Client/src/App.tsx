import { Country } from 'core/widgets/Country/Country';
import { Widget } from 'core/widgets/Widget';
import React from 'react';
import './App.css';

const App: React.FC = () => {
  return (
    <div className="map-wrapper">
      <Widget>
        <Country />
      </Widget>
    </div>

    
  );
}

export default App;
