import PropTypes from 'prop-types';
import React from 'react';
import MenuContent from 'Components/Menu/MenuContent';
import ViewMenu from 'Components/Menu/ViewMenu';
import ViewMenuItem from 'Components/Menu/ViewMenuItem';
import { align } from 'Helpers/Props';

function BookIndexViewMenu(props) {
  const {
    view,
    isDisabled,
    onViewSelect
  } = props;

  return (
    <ViewMenu
      isDisabled={isDisabled}
      alignMenu={align.RIGHT}
    >
      <MenuContent>
        <ViewMenuItem
          name="table"
          selectedView={view}
          onPress={onViewSelect}
        >
          Table
        </ViewMenuItem>

        <ViewMenuItem
          name="posters"
          selectedView={view}
          onPress={onViewSelect}
        >
          Posters
        </ViewMenuItem>

        <ViewMenuItem
          name="overview"
          selectedView={view}
          onPress={onViewSelect}
        >
          Overview
        </ViewMenuItem>
      </MenuContent>
    </ViewMenu>
  );
}

BookIndexViewMenu.propTypes = {
  view: PropTypes.string.isRequired,
  isDisabled: PropTypes.bool.isRequired,
  onViewSelect: PropTypes.func.isRequired
};

export default BookIndexViewMenu;
