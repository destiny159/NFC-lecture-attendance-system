import { userService } from "../../services/user.service";

const state = {
    all: {},
};

const actions = {
    getAll({ commit }) {
        commit("getAllRequest");

        userService.getAll()
            .then(
                users => commit("getAllSuccess", users),
                returnError => commit("getAllFailure", returnError),
            );
    },

    delete({ commit }, id) {
        commit("deleteRequest", id);

        userService.delete(id)
            .then(
                user => commit("deleteSuccess", id),
                returnError => commit("deleteSuccess", { id, returnError: returnError.toString() }),
            );
    },
};

const mutations = {
    getAllRequest(state) {
        state.all = { loading: true };
    },
    getAllSuccess(state, users) {
        state.all = { items: users };
    },
    getAllFailure(state, returnError) {
        state.all = { returnError };
    },
    deleteRequest(state, id) {
        // add 'deleting:true' property to user being deleted
        state.all.items = state.all.items.map(user =>
            user.id === id
                ? { ...user, deleting: true }
                : user,
        );
    },
    deleteSuccess(state, id) {
        // remove deleted user from state
        state.all.items = state.all.items.filter(user => user.id !== id);
    },
    deleteFailure(state, { id, returnError }) {
        // remove 'deleting:true' property and add 'deleteError:[error]' property to user
        state.all.items = state.items.map(user => {
            if (user.id === id) {
                // make copy of user without 'deleting:true' property
                const { deleting, ...userCopy } = user;
                // return copy of user with 'deleteError:[error]' property
                return { ...userCopy, deleteError: returnError };
            }

            return user;
        });
    },
};

export const users = {
    namespaced: true,
    state,
    actions,
    mutations,
};
